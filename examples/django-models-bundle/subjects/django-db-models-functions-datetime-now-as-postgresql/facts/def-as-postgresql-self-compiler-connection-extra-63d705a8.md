# Fact 63d705a8

Store id: 425ba59d-67d4-48f1-9e8d-fd40a2a6b2fe

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:53.3699070+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "method",
  "parent": "Now",
  "start_line": 217,
  "symbol": "Now.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":217,"selector":"L217-L223","symbol":"Now.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Now.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "method",
    "parent": "Now",
    "start_line": 217,
    "symbol": "Now.as_postgresql"
  },
  "id": "425ba59d-67d4-48f1-9e8d-fd40a2a6b2fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3699070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 217,
        "selector": "L217-L223",
        "symbol": "Now.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "45c08ba4-aa26-44b8-9146-35b2477f3a30",
  "subject_name": "django/db/models/functions/datetime::Now.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
