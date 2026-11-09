# Fact d37add92

Store id: 6fe74cb3-65a5-452d-b283-70835677305e

## Text

```text
def _check_max_length_warning(self)
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
- posted_at: `2026-11-09T22:39:42.5326770+00:00`

## Data

```json
{
  "end_line": 2165,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2154,
  "symbol": "IntegerField._check_max_length_warning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2154,"selector":"L2154-L2165","symbol":"IntegerField._check_max_length_warning"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField._check_max_length_warning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2165,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2154,
    "symbol": "IntegerField._check_max_length_warning"
  },
  "id": "6fe74cb3-65a5-452d-b283-70835677305e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5326770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2154,
        "selector": "L2154-L2165",
        "symbol": "IntegerField._check_max_length_warning"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ccfb106d-7a78-4f76-b20d-85366e246733",
  "subject_name": "django/db/models/fields/__init__::IntegerField._check_max_length_warning",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_max_length_warning(self)"
}
```
