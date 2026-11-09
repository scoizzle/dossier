# Fact 9824f51f

Store id: 7c1eac4d-c604-408b-b85a-2188e9f8653a

## Text

```text
def __setstate__(self, state)
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
- posted_at: `2026-11-09T22:39:40.3345600+00:00`

## Data

```json
{
  "end_line": 696,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 676,
  "symbol": "Model.__setstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":676,"selector":"L676-L696","symbol":"Model.__setstate__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__setstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 696,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 676,
    "symbol": "Model.__setstate__"
  },
  "id": "7c1eac4d-c604-408b-b85a-2188e9f8653a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3345600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 676,
        "selector": "L676-L696",
        "symbol": "Model.__setstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "8aea39d0-48d7-4bc8-a164-26f469137156",
  "subject_name": "django/db/models/base::Model.__setstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __setstate__(self, state)"
}
```
