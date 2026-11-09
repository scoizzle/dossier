# Fact 0ff0e8b0

Store id: 2ec7e47d-091a-49d8-a9da-466e659f01cc

## Text

```text
class RowNumber(Func)
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
- posted_at: `2026-11-09T22:39:47.6066130+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 117,
  "symbol": "RowNumber"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L120","symbol":"RowNumber"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::RowNumber](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 117,
    "symbol": "RowNumber"
  },
  "id": "2ec7e47d-091a-49d8-a9da-466e659f01cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.6066130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L120",
        "symbol": "RowNumber"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "84762bcc-d9c0-472d-ae26-5b7d8a54f0a9",
  "subject_name": "django/db/models/functions/window::RowNumber",
  "tags": [
    "entity:class"
  ],
  "text": "class RowNumber(Func)"
}
```
