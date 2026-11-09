# Fact 09f06e66

Store id: 915e4f50-4183-44ed-9f71-a4c116287c1a

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
- posted_at: `2026-11-09T23:32:02.1905430+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "Left",
  "start_line": 169,
  "symbol": "Left.get_substr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":169,"selector":"L169-L170","symbol":"Left.get_substr"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left.get_substr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "Left",
    "start_line": 169,
    "symbol": "Left.get_substr"
  },
  "id": "915e4f50-4183-44ed-9f71-a4c116287c1a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1905430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 169,
        "selector": "L169-L170",
        "symbol": "Left.get_substr"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "6f5f5f68-7001-428b-b686-3a4157079e4c",
  "subject_name": "django/db/models/functions/text::Left.get_substr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_substr(self)"
}
```
