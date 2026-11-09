# Fact 9be9992a

Store id: ea78dd48-c443-492e-b05e-0821c77e65a1

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
- posted_at: `2026-11-09T23:31:56.6641380+00:00`

## Data

```json
{
  "end_line": 2010,
  "entity_kind": "method",
  "parent": "EmailField",
  "start_line": 2006,
  "symbol": "EmailField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2006,"selector":"L2006-L2010","symbol":"EmailField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::EmailField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2010,
    "entity_kind": "method",
    "parent": "EmailField",
    "start_line": 2006,
    "symbol": "EmailField.deconstruct"
  },
  "id": "ea78dd48-c443-492e-b05e-0821c77e65a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6641380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2006,
        "selector": "L2006-L2010",
        "symbol": "EmailField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5e869b77-1ba8-4d27-aa80-e272f0ae6a00",
  "subject_name": "django/db/models/fields/__init__::EmailField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
