# Fact 4997fa02

Store id: dd8392ae-22c7-49c5-b229-609b7c4e6b25

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T22:39:42.6068560+00:00`

## Data

```json
{
  "end_line": 2446,
  "entity_kind": "method",
  "parent": "PositiveBigIntegerField",
  "start_line": 2445,
  "symbol": "PositiveBigIntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2445,"selector":"L2445-L2446","symbol":"PositiveBigIntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveBigIntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2446,
    "entity_kind": "method",
    "parent": "PositiveBigIntegerField",
    "start_line": 2445,
    "symbol": "PositiveBigIntegerField.get_internal_type"
  },
  "id": "dd8392ae-22c7-49c5-b229-609b7c4e6b25",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6068560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2445,
        "selector": "L2445-L2446",
        "symbol": "PositiveBigIntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a82d8b25-64e4-48fb-b3a0-3e508e162036",
  "subject_name": "django/db/models/fields/__init__::PositiveBigIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
