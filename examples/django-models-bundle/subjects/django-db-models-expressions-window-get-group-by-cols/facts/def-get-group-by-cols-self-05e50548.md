# Fact 05e50548

Store id: 85d83f26-e047-4a00-82ea-66e34ff193b1

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T22:39:41.7679270+00:00`

## Data

```json
{
  "end_line": 2124,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2118,
  "symbol": "Window.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2118,"selector":"L2118-L2124","symbol":"Window.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2124,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2118,
    "symbol": "Window.get_group_by_cols"
  },
  "id": "85d83f26-e047-4a00-82ea-66e34ff193b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7679270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2118,
        "selector": "L2118-L2124",
        "symbol": "Window.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e50cbb01-0194-4f5c-9500-a43b0cb8e066",
  "subject_name": "django/db/models/expressions::Window.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
