# Fact f5d0d9e9

Store id: ea08084b-3975-430f-a699-d253ba83c608

## Text

```text
def __init__( self, verbose_name=None, name=None, primary_key=False, max_length=None, unique=False, blank=False, null=False, db_index=False, rel=None, default=NOT_PROVIDED, editable=True, serialize=True, unique_for_date=None,…
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `signature_truncated`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.2617140+00:00`

## Data

```json
{
  "end_line": 279,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 219,
  "symbol": "Field.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":219,"selector":"L219-L279","symbol":"Field.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 279,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 219,
    "symbol": "Field.__init__"
  },
  "id": "ea08084b-3975-430f-a699-d253ba83c608",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2617140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 219,
        "selector": "L219-L279",
        "symbol": "Field.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4ed22f82-df26-45c0-ba2e-e7b05fbcd267",
  "subject_name": "django/db/models/fields/__init__::Field.__init__",
  "tags": [
    "entity:method",
    "signature_truncated"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, primary_key=False, max_length=None, unique=False, blank=False, null=False, db_index=False, rel=None, default=NOT_PROVIDED, editable=True, serialize=True, unique_for_date=None,…"
}
```
