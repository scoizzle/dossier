# Fact f5d0d9e9

Store id: 1a9c7070-1276-4ba8-82ec-1ea87fc9e51d

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
- posted_at: `2026-11-09T23:31:56.4211270+00:00`

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
  "id": "1a9c7070-1276-4ba8-82ec-1ea87fc9e51d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4211270+00:00"
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
  "subject_id": "2ceaba6b-b4c5-43fb-882d-af97e4afe336",
  "subject_name": "django/db/models/fields/__init__::Field.__init__",
  "tags": [
    "entity:method",
    "signature_truncated"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, primary_key=False, max_length=None, unique=False, blank=False, null=False, db_index=False, rel=None, default=NOT_PROVIDED, editable=True, serialize=True, unique_for_date=None,…"
}
```
