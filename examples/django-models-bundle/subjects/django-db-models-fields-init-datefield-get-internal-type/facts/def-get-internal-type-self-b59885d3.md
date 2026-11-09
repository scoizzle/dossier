# Fact b59885d3

Store id: 858d3289-532c-4d45-8e4b-6f7606d0f8fe

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
- posted_at: `2026-11-09T23:31:56.5806290+00:00`

## Data

```json
{
  "end_line": 1518,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1517,
  "symbol": "DateField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1517,"selector":"L1517-L1518","symbol":"DateField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1518,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1517,
    "symbol": "DateField.get_internal_type"
  },
  "id": "858d3289-532c-4d45-8e4b-6f7606d0f8fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5806290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1517,
        "selector": "L1517-L1518",
        "symbol": "DateField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "887d4449-8a86-4ddc-a6e5-dc4f46b59f20",
  "subject_name": "django/db/models/fields/__init__::DateField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
