# Fact 1961ef67

Store id: ca311a66-5dc0-45fb-8283-4cd1b5776da4

## Text

```text
def _check_db_default(self, databases=None, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.4298670+00:00`

## Data

```json
{
  "end_line": 459,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 425,
  "symbol": "Field._check_db_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"selector":"L425-L459","symbol":"Field._check_db_default"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_db_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 459,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 425,
    "symbol": "Field._check_db_default"
  },
  "id": "ca311a66-5dc0-45fb-8283-4cd1b5776da4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4298670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 425,
        "selector": "L425-L459",
        "symbol": "Field._check_db_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "65b7d0bc-da87-4061-8fc7-9cf83139f1f8",
  "subject_name": "django/db/models/fields/__init__::Field._check_db_default",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_default(self, databases=None, **kwargs)"
}
```
