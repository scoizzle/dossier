# Fact 93728479

Store id: 48d455c3-3ec3-4696-be73-cb7244e88e7d

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:43.2704450+00:00`

## Data

```json
{
  "end_line": 466,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 460,
  "symbol": "ImageField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":460,"selector":"L460-L466","symbol":"ImageField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 466,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 460,
    "symbol": "ImageField.deconstruct"
  },
  "id": "48d455c3-3ec3-4696-be73-cb7244e88e7d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2704450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 460,
        "selector": "L460-L466",
        "symbol": "ImageField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "34185c38-f1d1-464b-ba9a-2ceed227e6d1",
  "subject_name": "django/db/models/fields/files::ImageField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
