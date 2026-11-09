# Fact 355a034f

Store id: 5af3ba76-0696-44e4-913e-6f6c9e7b6f80

## Text

```text
class Replace(Func)
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
- posted_at: `2026-11-09T22:39:47.1505230+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 253,
  "symbol": "Replace"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":253,"selector":"L253-L257","symbol":"Replace"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Replace](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 253,
    "symbol": "Replace"
  },
  "id": "5af3ba76-0696-44e4-913e-6f6c9e7b6f80",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1505230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 253,
        "selector": "L253-L257",
        "symbol": "Replace"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "a0dc1d66-41bc-4010-a1c7-fef698eee71a",
  "subject_name": "django/db/models/functions/text::Replace",
  "tags": [
    "entity:class"
  ],
  "text": "class Replace(Func)"
}
```
