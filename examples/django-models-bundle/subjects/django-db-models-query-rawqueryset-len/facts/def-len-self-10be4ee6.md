# Fact 10be4ee6

Store id: 45007162-52e0-4862-aaf8-3a3867e3cba7

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
- posted_at: `2026-11-09T23:32:04.7331120+00:00`

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
  "id": "45007162-52e0-4862-aaf8-3a3867e3cba7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7331120+00:00"
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
  "subject_id": "7309cc7d-a86a-4218-838e-28e378d11b57",
  "subject_name": "django/db/models/query::RawQuerySet.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
