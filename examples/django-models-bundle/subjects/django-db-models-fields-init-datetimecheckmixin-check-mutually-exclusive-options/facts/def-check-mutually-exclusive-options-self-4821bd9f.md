# Fact 4821bd9f

Store id: 6d5892ae-830a-4fcf-9542-d494d023ec96

## Text

```text
def _check_mutually_exclusive_options(self)
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
- posted_at: `2026-11-09T23:44:50.0809410+00:00`

## Data

```json
{
  "end_line": 1422,
  "entity_kind": "method",
  "parent": "DateTimeCheckMixin",
  "start_line": 1399,
  "symbol": "DateTimeCheckMixin._check_mutually_exclusive_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1399,"selector":"L1399-L1422","symbol":"DateTimeCheckMixin._check_mutually_exclusive_options"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin._check_mutually_exclusive_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1422,
    "entity_kind": "method",
    "parent": "DateTimeCheckMixin",
    "start_line": 1399,
    "symbol": "DateTimeCheckMixin._check_mutually_exclusive_options"
  },
  "id": "6d5892ae-830a-4fcf-9542-d494d023ec96",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0809410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1399,
        "selector": "L1399-L1422",
        "symbol": "DateTimeCheckMixin._check_mutually_exclusive_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2146cf10-7928-4957-907e-7c9824a9e90e",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_mutually_exclusive_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_mutually_exclusive_options(self)"
}
```
