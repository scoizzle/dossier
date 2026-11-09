# Fact 67a366ef

Store id: 4c4c6617-dd99-40d7-89b7-cbc8258d8d0b

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
- posted_at: `2026-11-09T23:31:56.6486350+00:00`

## Data

```json
{
  "end_line": 1973,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1956,
  "symbol": "DurationField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1956,"selector":"L1956-L1973","symbol":"DurationField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1973,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1956,
    "symbol": "DurationField.to_python"
  },
  "id": "4c4c6617-dd99-40d7-89b7-cbc8258d8d0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6486350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1956,
        "selector": "L1956-L1973",
        "symbol": "DurationField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "38a80267-98a4-4987-960f-a6f96b6083b1",
  "subject_name": "django/db/models/fields/__init__::DurationField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
