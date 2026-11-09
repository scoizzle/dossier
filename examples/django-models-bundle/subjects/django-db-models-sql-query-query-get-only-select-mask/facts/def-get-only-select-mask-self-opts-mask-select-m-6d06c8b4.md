# Fact 6d06c8b4

Store id: 95a4fd4b-71dc-49be-8bd9-fafa986751bf

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
- posted_at: `2026-11-09T23:32:06.8222270+00:00`

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
  "id": "95a4fd4b-71dc-49be-8bd9-fafa986751bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8222270+00:00"
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
  "subject_id": "05f76c7c-cd10-4d9c-9fe6-c3ef47bcbd49",
  "subject_name": "django/db/models/sql/query::Query._get_only_select_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_only_select_mask(self, opts, mask, select_mask=None)"
}
```
