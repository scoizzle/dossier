# Fact ec6f63e3

Store id: 323c9f7b-b52a-4adf-a076-116a5e23cfe4

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.4459280+00:00`

## Data

```json
{
  "end_line": 1770,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1758,
  "symbol": "DecimalField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1758,"selector":"L1758-L1770","symbol":"DecimalField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1770,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1758,
    "symbol": "DecimalField.check"
  },
  "id": "323c9f7b-b52a-4adf-a076-116a5e23cfe4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4459280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1758,
        "selector": "L1758-L1770",
        "symbol": "DecimalField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b8decbc0-b0ea-4ade-a7b8-82ac8afac698",
  "subject_name": "django/db/models/fields/__init__::DecimalField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
