# Fact 912482d5

Store id: 202795c2-f9b4-4f5a-aeba-cd99229f160c

## Text

```text
def _get_defer_select_mask(self, opts, mask, select_mask=None)
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
- posted_at: `2026-11-09T23:44:58.6929110+00:00`

## Data

```json
{
  "end_line": 858,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 816,
  "symbol": "Query._get_defer_select_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":816,"selector":"L816-L858","symbol":"Query._get_defer_select_mask"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._get_defer_select_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 858,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 816,
    "symbol": "Query._get_defer_select_mask"
  },
  "id": "202795c2-f9b4-4f5a-aeba-cd99229f160c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6929110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 816,
        "selector": "L816-L858",
        "symbol": "Query._get_defer_select_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1da80525-0666-4b19-8f75-f5246138404d",
  "subject_name": "django/db/models/sql/query::Query._get_defer_select_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_defer_select_mask(self, opts, mask, select_mask=None)"
}
```
