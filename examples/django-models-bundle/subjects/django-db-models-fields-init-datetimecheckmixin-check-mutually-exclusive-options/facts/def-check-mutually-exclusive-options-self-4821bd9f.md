# Fact 4821bd9f

Store id: b79301a3-8dea-4a81-9c63-45d333348e93

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
- posted_at: `2026-11-09T22:39:42.4050370+00:00`

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
  "id": "b79301a3-8dea-4a81-9c63-45d333348e93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4050370+00:00"
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
  "subject_id": "9c4f7d45-e351-4c50-983f-6f95f29005b6",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_mutually_exclusive_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_mutually_exclusive_options(self)"
}
```
