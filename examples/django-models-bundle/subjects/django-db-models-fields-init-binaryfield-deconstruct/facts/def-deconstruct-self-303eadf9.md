# Fact 303eadf9

Store id: 992e3eb6-19dd-453e-a9f1-49b4e1ef7abd

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
- posted_at: `2026-11-09T22:39:42.6938980+00:00`

## Data

```json
{
  "end_line": 2778,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2772,
  "symbol": "BinaryField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2772,"selector":"L2772-L2778","symbol":"BinaryField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2778,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2772,
    "symbol": "BinaryField.deconstruct"
  },
  "id": "992e3eb6-19dd-453e-a9f1-49b4e1ef7abd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6938980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2772,
        "selector": "L2772-L2778",
        "symbol": "BinaryField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0475eb6c-2712-4d28-836d-1818a20cadc7",
  "subject_name": "django/db/models/fields/__init__::BinaryField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
