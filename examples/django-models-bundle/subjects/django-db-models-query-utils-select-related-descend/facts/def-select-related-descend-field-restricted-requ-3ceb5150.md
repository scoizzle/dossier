# Fact 3ceb5150

Store id: 5b9daaa9-148e-4079-b914-cb69868a5067

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
- posted_at: `2026-11-09T22:39:50.1706410+00:00`

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
  "id": "5b9daaa9-148e-4079-b914-cb69868a5067",
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
    "posted_at": "2026-11-09T22:39:50.1706410+00:00"
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
  "subject_id": "7e64db42-7713-4bf0-bd98-88d662c4f947",
  "subject_name": "django/db/models/query_utils::select_related_descend",
  "tags": [
    "entity:function"
  ],
  "text": "def select_related_descend(field, restricted, requested, select_mask)"
}
```
