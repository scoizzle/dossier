# Fact 8e02af78

Store id: 78b023cf-ef23-4549-819c-98218045a10c

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
- posted_at: `2026-11-09T23:44:50.1922210+00:00`

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
  "id": "78b023cf-ef23-4549-819c-98218045a10c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1922210+00:00"
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
  "subject_id": "508edf13-a1ed-40f5-b4da-83d4efe9bae7",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField._check_blank_and_null_values",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_blank_and_null_values(self, **kwargs)"
}
```
