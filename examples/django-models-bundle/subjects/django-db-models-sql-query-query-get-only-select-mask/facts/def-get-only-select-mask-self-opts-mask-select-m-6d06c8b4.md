# Fact 6d06c8b4

Store id: ab207366-c8ca-423e-92dc-9a7e4415b3f0

## Text

```text
def _get_only_select_mask(self, opts, mask, select_mask=None)
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
- posted_at: `2026-11-09T22:39:51.2807340+00:00`

## Data

```json
{
  "end_line": 875,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 860,
  "symbol": "Query._get_only_select_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":860,"selector":"L860-L875","symbol":"Query._get_only_select_mask"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._get_only_select_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 875,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 860,
    "symbol": "Query._get_only_select_mask"
  },
  "id": "ab207366-c8ca-423e-92dc-9a7e4415b3f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2807340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 860,
        "selector": "L860-L875",
        "symbol": "Query._get_only_select_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "017437bc-f93c-45bd-9cda-eae46f3d69dd",
  "subject_name": "django/db/models/sql/query::Query._get_only_select_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_only_select_mask(self, opts, mask, select_mask=None)"
}
```
