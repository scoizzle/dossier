# Fact 2991918d

Store id: f1981ba9-a1c5-4e47-8efa-1c429f3647d8

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
- posted_at: `2026-11-09T22:39:42.6607350+00:00`

## Data

```json
{
  "end_line": 2655,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2646,
  "symbol": "TimeField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2646,"selector":"L2646-L2655","symbol":"TimeField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2655,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2646,
    "symbol": "TimeField.deconstruct"
  },
  "id": "f1981ba9-a1c5-4e47-8efa-1c429f3647d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6607350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2646,
        "selector": "L2646-L2655",
        "symbol": "TimeField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cc415d27-0b71-4066-ae96-c1289c4cb385",
  "subject_name": "django/db/models/fields/__init__::TimeField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
