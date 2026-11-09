# Fact 10be4ee6

Store id: 94d631ea-316e-44af-8846-98972924cfc9

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T23:44:56.2353120+00:00`

## Data

```json
{
  "end_line": 2493,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2491,
  "symbol": "RawQuerySet.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2491,"selector":"L2491-L2493","symbol":"RawQuerySet.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2493,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2491,
    "symbol": "RawQuerySet.__len__"
  },
  "id": "94d631ea-316e-44af-8846-98972924cfc9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2353120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2491,
        "selector": "L2491-L2493",
        "symbol": "RawQuerySet.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6420579e-fbe9-4488-b45c-4fde82ccf82d",
  "subject_name": "django/db/models/query::RawQuerySet.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
