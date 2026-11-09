# Fact 2d39baf5

Store id: 89a1d613-343d-452b-ac7c-6affdfb08244

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.1257950+00:00`

## Data

```json
{
  "end_line": 1933,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1925,
  "symbol": "DecimalField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1925,"selector":"L1925-L1933","symbol":"DecimalField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1933,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1925,
    "symbol": "DecimalField.formfield"
  },
  "id": "89a1d613-343d-452b-ac7c-6affdfb08244",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1257950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1925,
        "selector": "L1925-L1933",
        "symbol": "DecimalField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9802c067-1c0b-4cfe-b323-dae5b04b889e",
  "subject_name": "django/db/models/fields/__init__::DecimalField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
