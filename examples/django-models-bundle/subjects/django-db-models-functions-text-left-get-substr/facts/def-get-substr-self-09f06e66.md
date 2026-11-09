# Fact 09f06e66

Store id: 0ae4c888-45a8-401c-90a9-84f1cb860f29

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
- posted_at: `2026-11-09T23:44:54.0871290+00:00`

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
  "id": "0ae4c888-45a8-401c-90a9-84f1cb860f29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0871290+00:00"
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
  "subject_id": "2498f0f6-7b40-44ac-be9f-f6086d97c52a",
  "subject_name": "django/db/models/functions/text::Left.get_substr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_substr(self)"
}
```
