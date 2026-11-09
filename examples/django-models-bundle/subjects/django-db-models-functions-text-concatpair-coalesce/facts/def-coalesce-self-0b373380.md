# Fact 0b373380

Store id: b186b1df-f963-414d-9564-507db282e794

## Text

```text
def coalesce(self)
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
- posted_at: `2026-11-09T22:39:47.0882710+00:00`

## Data

```json
{
  "end_line": 122,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 112,
  "symbol": "ConcatPair.coalesce"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":112,"selector":"L112-L122","symbol":"ConcatPair.coalesce"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.coalesce](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 122,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 112,
    "symbol": "ConcatPair.coalesce"
  },
  "id": "b186b1df-f963-414d-9564-507db282e794",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0882710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 112,
        "selector": "L112-L122",
        "symbol": "ConcatPair.coalesce"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "92ccfc95-617d-43b0-a4da-75bb8808ce70",
  "subject_name": "django/db/models/functions/text::ConcatPair.coalesce",
  "tags": [
    "entity:method"
  ],
  "text": "def coalesce(self)"
}
```
