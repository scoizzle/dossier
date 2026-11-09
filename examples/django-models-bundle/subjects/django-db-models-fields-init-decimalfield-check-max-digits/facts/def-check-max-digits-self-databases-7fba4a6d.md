# Fact 7fba4a6d

Store id: e6929ae1-9925-4db7-b8ba-194bf2ded163

## Text

```text
def _check_max_digits(self, databases)
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
- posted_at: `2026-11-09T23:31:56.6236050+00:00`

## Data

```json
{
  "end_line": 1856,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1815,
  "symbol": "DecimalField._check_max_digits"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1815,"selector":"L1815-L1856","symbol":"DecimalField._check_max_digits"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField._check_max_digits](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1856,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1815,
    "symbol": "DecimalField._check_max_digits"
  },
  "id": "e6929ae1-9925-4db7-b8ba-194bf2ded163",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6236050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1815,
        "selector": "L1815-L1856",
        "symbol": "DecimalField._check_max_digits"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cd006e24-5a84-43c5-bd23-ae3fe45e38dc",
  "subject_name": "django/db/models/fields/__init__::DecimalField._check_max_digits",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_max_digits(self, databases)"
}
```
