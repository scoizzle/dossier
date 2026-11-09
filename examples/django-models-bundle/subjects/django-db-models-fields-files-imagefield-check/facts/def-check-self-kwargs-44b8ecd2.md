# Fact 44b8ecd2

Store id: fb613c57-1601-40c2-b35f-bbf0bc269406

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.2666180+00:00`

## Data

```json
{
  "end_line": 440,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 436,
  "symbol": "ImageField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":436,"selector":"L436-L440","symbol":"ImageField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 440,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 436,
    "symbol": "ImageField.check"
  },
  "id": "fb613c57-1601-40c2-b35f-bbf0bc269406",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2666180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 436,
        "selector": "L436-L440",
        "symbol": "ImageField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "324f60f9-e7f1-41f8-b2c7-5684608e11f1",
  "subject_name": "django/db/models/fields/files::ImageField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
