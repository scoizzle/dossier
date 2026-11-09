# Fact a8990f3b

Store id: e0a4c695-92f4-4577-9f5a-4f8903434ec3

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
- posted_at: `2026-11-09T23:31:58.6782170+00:00`

## Data

```json
{
  "end_line": 780,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 747,
  "symbol": "ForeignObject.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":747,"selector":"L747-L780","symbol":"ForeignObject.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 780,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 747,
    "symbol": "ForeignObject.deconstruct"
  },
  "id": "e0a4c695-92f4-4577-9f5a-4f8903434ec3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6782170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 747,
        "selector": "L747-L780",
        "symbol": "ForeignObject.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "77ca7ce0-7c7e-4012-b3cf-5603aefa9b89",
  "subject_name": "django/db/models/fields/related::ForeignObject.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
