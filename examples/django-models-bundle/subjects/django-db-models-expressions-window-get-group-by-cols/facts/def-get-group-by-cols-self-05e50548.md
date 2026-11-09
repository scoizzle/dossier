# Fact 05e50548

Store id: 93dd4e64-2357-43fb-8761-d0566a5884fa

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
- posted_at: `2026-11-09T23:31:56.0091380+00:00`

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
  "id": "93dd4e64-2357-43fb-8761-d0566a5884fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0091380+00:00"
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
  "subject_id": "3ec528d6-ffce-40c8-8d82-ad0a161d80f7",
  "subject_name": "django/db/models/expressions::Window.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
