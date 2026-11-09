# Fact 93728479

Store id: 92458a6b-ab2f-4db1-812f-4eefdec35fb8

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
- posted_at: `2026-11-09T23:31:57.4382250+00:00`

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
  "id": "92458a6b-ab2f-4db1-812f-4eefdec35fb8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4382250+00:00"
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
  "subject_id": "9ed5a051-e5ac-4185-a0fc-268b1e1b09fa",
  "subject_name": "django/db/models/fields/files::ImageField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
