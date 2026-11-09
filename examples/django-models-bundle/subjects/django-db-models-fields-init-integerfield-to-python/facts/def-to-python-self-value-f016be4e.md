# Fact f016be4e

Store id: 3f463f1f-57e1-48e1-bb37-67ac06178782

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T22:39:42.5428690+00:00`

## Data

```json
{
  "end_line": 2230,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2220,
  "symbol": "IntegerField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2230","symbol":"IntegerField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2230,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2220,
    "symbol": "IntegerField.to_python"
  },
  "id": "3f463f1f-57e1-48e1-bb37-67ac06178782",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5428690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2230",
        "symbol": "IntegerField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a60745fb-6de5-4c75-89c9-620982b9b009",
  "subject_name": "django/db/models/fields/__init__::IntegerField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
