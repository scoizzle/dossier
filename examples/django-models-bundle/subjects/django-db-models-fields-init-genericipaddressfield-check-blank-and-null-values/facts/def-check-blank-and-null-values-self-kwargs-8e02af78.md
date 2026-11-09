# Fact 8e02af78

Store id: f99a21fe-c8a9-4860-9b89-51e2d27be756

## Text

```text
def _check_blank_and_null_values(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.7391610+00:00`

## Data

```json
{
  "end_line": 2334,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2324,
  "symbol": "GenericIPAddressField._check_blank_and_null_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2324,"selector":"L2324-L2334","symbol":"GenericIPAddressField._check_blank_and_null_values"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField._check_blank_and_null_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2334,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2324,
    "symbol": "GenericIPAddressField._check_blank_and_null_values"
  },
  "id": "f99a21fe-c8a9-4860-9b89-51e2d27be756",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7391610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2324,
        "selector": "L2324-L2334",
        "symbol": "GenericIPAddressField._check_blank_and_null_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "44d08406-0cd2-4c19-8ba9-51d9d7c036c8",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField._check_blank_and_null_values",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_blank_and_null_values(self, **kwargs)"
}
```
