# Fact b59885d3

Store id: a7852a28-36ed-4986-b610-6fce9bfc4851

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
- posted_at: `2026-11-09T22:39:42.4162810+00:00`

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
  "id": "a7852a28-36ed-4986-b610-6fce9bfc4851",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4162810+00:00"
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
  "subject_id": "2e241196-434b-4d57-8b72-397091c6d8ef",
  "subject_name": "django/db/models/fields/__init__::DateField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
