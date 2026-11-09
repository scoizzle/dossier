# Fact ec6f63e3

Store id: 748f8403-eda8-41fd-81b9-8efe00ddb782

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
- posted_at: `2026-11-09T23:31:56.6177000+00:00`

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
  "id": "748f8403-eda8-41fd-81b9-8efe00ddb782",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6177000+00:00"
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
  "subject_id": "33d77ae4-7b8d-49a5-b948-0e620dd84aef",
  "subject_name": "django/db/models/fields/__init__::DecimalField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
