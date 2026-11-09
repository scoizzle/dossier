# Fact 3ceb5150

Store id: 55e2070f-4871-4f1c-ab42-1568130b2b25

## Text

```text
def select_related_descend(field, restricted, requested, select_mask)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.7154680+00:00`

## Data

```json
{
  "end_line": 475,
  "entity_kind": "function",
  "parent": "query_utils",
  "start_line": 440,
  "symbol": "select_related_descend"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":440,"selector":"L440-L475","symbol":"select_related_descend"}`

## Items

```json
[
  {
    "text": "Return whether `field` should be used to descend deeper for `select_related()` purposes.",
    "locator": {
      "line": 441
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::select_related_descend](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 475,
    "entity_kind": "function",
    "parent": "query_utils",
    "start_line": 440,
    "symbol": "select_related_descend"
  },
  "id": "55e2070f-4871-4f1c-ab42-1568130b2b25",
  "items": [
    {
      "locator": {
        "line": 441
      },
      "text": "Return whether `field` should be used to descend deeper for `select_related()` purposes."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7154680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 440,
        "selector": "L440-L475",
        "symbol": "select_related_descend"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "301a5df9-77e7-463e-9e4a-5ff8c5fceaf9",
  "subject_name": "django/db/models/query_utils::select_related_descend",
  "tags": [
    "entity:function"
  ],
  "text": "def select_related_descend(field, restricted, requested, select_mask)"
}
```
