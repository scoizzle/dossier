# Fact 0b373380

Store id: 021cb3e4-cb71-4264-9694-5c0a7f24bc53

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
- posted_at: `2026-11-09T23:44:54.0725460+00:00`

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
  "id": "021cb3e4-cb71-4264-9694-5c0a7f24bc53",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0725460+00:00"
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
  "subject_id": "89e1d15f-0c8d-46a2-92cf-9eac62d58d91",
  "subject_name": "django/db/models/functions/text::ConcatPair.coalesce",
  "tags": [
    "entity:method"
  ],
  "text": "def coalesce(self)"
}
```
