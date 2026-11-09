# Fact 6b8c020e

Store id: 4310c49c-cc80-4ccb-bd53-4fc685d1270a

## Text

```text
class LastValue(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:02.6999120+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 64,
  "symbol": "LastValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L67","symbol":"LastValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::LastValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 64,
    "symbol": "LastValue"
  },
  "id": "4310c49c-cc80-4ccb-bd53-4fc685d1270a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.6999120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L67",
        "symbol": "LastValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "7ca460b0-669b-4c44-a6ae-eaa04bd0855d",
  "subject_name": "django/db/models/functions/window::LastValue",
  "tags": [
    "entity:class"
  ],
  "text": "class LastValue(Func)"
}
```
