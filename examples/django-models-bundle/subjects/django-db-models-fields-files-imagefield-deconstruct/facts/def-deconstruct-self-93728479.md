# Fact 93728479

Store id: 3e100ef3-db20-4e6b-9d16-752846523d9e

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
- posted_at: `2026-11-09T23:44:50.6814540+00:00`

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
  "id": "3e100ef3-db20-4e6b-9d16-752846523d9e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6814540+00:00"
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
  "subject_id": "c9075a8d-4054-466e-8569-31a0a4073674",
  "subject_name": "django/db/models/fields/files::ImageField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
