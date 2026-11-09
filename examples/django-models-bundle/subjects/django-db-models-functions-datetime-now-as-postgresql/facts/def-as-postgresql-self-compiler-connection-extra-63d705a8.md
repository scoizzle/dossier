# Fact 63d705a8

Store id: 4cf30262-d9ab-4999-ae3a-252f121b2c49

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
- posted_at: `2026-11-09T22:39:46.1617340+00:00`

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
  "id": "4cf30262-d9ab-4999-ae3a-252f121b2c49",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1617340+00:00"
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
  "subject_id": "d7062cc4-601e-4ee7-8d1b-b4356f647257",
  "subject_name": "django/db/models/functions/datetime::Now.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
