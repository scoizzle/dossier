# Fact 6f1f6724

Store id: 72b4a4e9-2d79-4d5b-85b4-8bead92993b4

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T22:39:47.0945460+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "Concat",
  "start_line": 135,
  "symbol": "Concat.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L139","symbol":"Concat.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Concat.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "Concat",
    "start_line": 135,
    "symbol": "Concat.__init__"
  },
  "id": "72b4a4e9-2d79-4d5b-85b4-8bead92993b4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0945460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L139",
        "symbol": "Concat.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "df2d059f-f676-4d71-8203-5329e31be9fd",
  "subject_name": "django/db/models/functions/text::Concat.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
