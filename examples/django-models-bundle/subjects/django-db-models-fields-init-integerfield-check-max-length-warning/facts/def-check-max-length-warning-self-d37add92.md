# Fact d37add92

Store id: 5d777b6a-2193-478d-835d-e922ef37f6a0

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
- posted_at: `2026-11-09T23:31:56.6950280+00:00`

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
  "id": "5d777b6a-2193-478d-835d-e922ef37f6a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6950280+00:00"
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
  "subject_id": "5553a694-b7e8-4283-85c3-b03448eaa55b",
  "subject_name": "django/db/models/fields/__init__::IntegerField._check_max_length_warning",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_max_length_warning(self)"
}
```
