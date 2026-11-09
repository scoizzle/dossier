# Fact 2871a0a1

Store id: 3184c499-94c2-4f47-a593-62d1cb91da45

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
- posted_at: `2026-11-09T23:44:51.6173300+00:00`

## Data

```json
{
  "end_line": 1379,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1375,
  "symbol": "OneToOneField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1375,"selector":"L1375-L1379","symbol":"OneToOneField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1379,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1375,
    "symbol": "OneToOneField.deconstruct"
  },
  "id": "3184c499-94c2-4f47-a593-62d1cb91da45",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6173300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1375,
        "selector": "L1375-L1379",
        "symbol": "OneToOneField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9bd793cf-712e-4b3c-87c5-28be31ff856a",
  "subject_name": "django/db/models/fields/related::OneToOneField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
