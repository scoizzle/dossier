# Fact 9270fbe8

Store id: d65356ec-56f0-4352-85b2-0b7a6006741c

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
- posted_at: `2026-11-09T23:31:56.7068020+00:00`

## Data

```json
{
  "end_line": 2238,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2232,
  "symbol": "IntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2232,"selector":"L2232-L2238","symbol":"IntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2238,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2232,
    "symbol": "IntegerField.formfield"
  },
  "id": "d65356ec-56f0-4352-85b2-0b7a6006741c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7068020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2232,
        "selector": "L2232-L2238",
        "symbol": "IntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "eed8d291-06d7-4e0b-9826-ffb8bb34048d",
  "subject_name": "django/db/models/fields/__init__::IntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
