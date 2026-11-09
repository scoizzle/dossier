# Fact a7b33e57

Store id: 385d2f3b-08a1-40eb-9ef5-84a7d71ad57a

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
- posted_at: `2026-11-09T23:31:56.6935070+00:00`

## Data

```json
{
  "end_line": 2152,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2148,
  "symbol": "IntegerField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2148,"selector":"L2148-L2152","symbol":"IntegerField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2152,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2148,
    "symbol": "IntegerField.check"
  },
  "id": "385d2f3b-08a1-40eb-9ef5-84a7d71ad57a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6935070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2148,
        "selector": "L2148-L2152",
        "symbol": "IntegerField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "238d83b0-661a-4826-9e39-63aba9ab7890",
  "subject_name": "django/db/models/fields/__init__::IntegerField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
