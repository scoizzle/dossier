# Fact 529b59e7

Store id: 3ed7501b-391b-4877-9fcd-9b1fed20df40

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
- posted_at: `2026-11-09T23:44:50.1739770+00:00`

## Data

```json
{
  "end_line": 2255,
  "entity_kind": "method",
  "parent": "BigIntegerField",
  "start_line": 2248,
  "symbol": "BigIntegerField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2248,"selector":"L2248-L2255","symbol":"BigIntegerField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigIntegerField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2255,
    "entity_kind": "method",
    "parent": "BigIntegerField",
    "start_line": 2248,
    "symbol": "BigIntegerField.formfield"
  },
  "id": "3ed7501b-391b-4877-9fcd-9b1fed20df40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1739770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2248,
        "selector": "L2248-L2255",
        "symbol": "BigIntegerField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1edd3048-b171-4e45-9c3d-e1504eb28a61",
  "subject_name": "django/db/models/fields/__init__::BigIntegerField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
