# Fact 4821bd9f

Store id: 4df9464e-6ad0-43ea-b8ae-22420435b9d7

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
- posted_at: `2026-11-09T23:31:56.5702960+00:00`

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
  "id": "4df9464e-6ad0-43ea-b8ae-22420435b9d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5702960+00:00"
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
  "subject_id": "cc59191a-72c7-4b21-9153-5c1e1bc435da",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_mutually_exclusive_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_mutually_exclusive_options(self)"
}
```
