# Fact c987518d

Store id: e26aaebd-d278-4a05-9636-e97f5590e7cc

## Text

```text
def get_substr(self)
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
- posted_at: `2026-11-09T22:39:47.1643170+00:00`

## Data

```json
{
  "end_line": 290,
  "entity_kind": "method",
  "parent": "Right",
  "start_line": 285,
  "symbol": "Right.get_substr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":285,"selector":"L285-L290","symbol":"Right.get_substr"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Right.get_substr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 290,
    "entity_kind": "method",
    "parent": "Right",
    "start_line": 285,
    "symbol": "Right.get_substr"
  },
  "id": "e26aaebd-d278-4a05-9636-e97f5590e7cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1643170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 285,
        "selector": "L285-L290",
        "symbol": "Right.get_substr"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "82d2d6d1-0caf-4286-a48e-73f734e1ad57",
  "subject_name": "django/db/models/functions/text::Right.get_substr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_substr(self)"
}
```
