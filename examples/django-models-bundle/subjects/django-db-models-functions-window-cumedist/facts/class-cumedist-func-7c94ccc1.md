# Fact 7c94ccc1

Store id: c36504bd-4d65-4c47-87d4-e0f4f4a6b442

## Text

```text
class CumeDist(Func)
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
- posted_at: `2026-11-09T23:32:02.6621230+00:00`

## Data

```json
{
  "end_line": 22,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 19,
  "symbol": "CumeDist"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L22","symbol":"CumeDist"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::CumeDist](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 22,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 19,
    "symbol": "CumeDist"
  },
  "id": "c36504bd-4d65-4c47-87d4-e0f4f4a6b442",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.6621230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L22",
        "symbol": "CumeDist"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "cf7b6ed7-5b71-47cf-9a87-1a54091751f8",
  "subject_name": "django/db/models/functions/window::CumeDist",
  "tags": [
    "entity:class"
  ],
  "text": "class CumeDist(Func)"
}
```
