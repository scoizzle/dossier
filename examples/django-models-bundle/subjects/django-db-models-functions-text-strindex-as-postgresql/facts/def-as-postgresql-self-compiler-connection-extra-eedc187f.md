# Fact eedc187f

Store id: 4c39b4c7-049f-4b17-9f73-ccbc23172b31

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
- posted_at: `2026-11-09T22:39:47.2016130+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "StrIndex",
  "start_line": 341,
  "symbol": "StrIndex.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":341,"selector":"L341-L342","symbol":"StrIndex.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::StrIndex.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "StrIndex",
    "start_line": 341,
    "symbol": "StrIndex.as_postgresql"
  },
  "id": "4c39b4c7-049f-4b17-9f73-ccbc23172b31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.2016130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 341,
        "selector": "L341-L342",
        "symbol": "StrIndex.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "92469298-74ef-476d-a154-2e8d6bedd6cc",
  "subject_name": "django/db/models/functions/text::StrIndex.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
