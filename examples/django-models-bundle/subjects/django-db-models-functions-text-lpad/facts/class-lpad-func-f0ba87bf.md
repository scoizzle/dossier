# Fact f0ba87bf

Store id: 03abec2d-b272-4763-9bcd-c34dde6a0c25

## Text

```text
class LPad(Func)
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
- posted_at: `2026-11-09T22:39:47.1230550+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 197,
  "symbol": "LPad"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L208","symbol":"LPad"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::LPad](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 197,
    "symbol": "LPad"
  },
  "id": "03abec2d-b272-4763-9bcd-c34dde6a0c25",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1230550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L208",
        "symbol": "LPad"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "65226962-418e-490c-b0e1-13b48af3545f",
  "subject_name": "django/db/models/functions/text::LPad",
  "tags": [
    "entity:class"
  ],
  "text": "class LPad(Func)"
}
```
