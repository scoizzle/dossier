# Fact 7f294748

Store id: 5b4037bc-7f00-4d6a-82dd-436278c69d71

## Text

```text
def _get_m2m_db_table(self, opts)
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
- posted_at: `2026-11-09T23:31:58.8726540+00:00`

## Data

```json
{
  "end_line": 2051,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2040,
  "symbol": "ManyToManyField._get_m2m_db_table"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2040,"selector":"L2040-L2051","symbol":"ManyToManyField._get_m2m_db_table"}`

## Items

```json
[
  {
    "text": "Function that can be curried to provide the m2m table name for this relation.",
    "locator": {
      "line": 2041
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._get_m2m_db_table](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2051,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2040,
    "symbol": "ManyToManyField._get_m2m_db_table"
  },
  "id": "5b4037bc-7f00-4d6a-82dd-436278c69d71",
  "items": [
    {
      "locator": {
        "line": 2041
      },
      "text": "Function that can be curried to provide the m2m table name for this relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8726540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2040,
        "selector": "L2040-L2051",
        "symbol": "ManyToManyField._get_m2m_db_table"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a2f6519d-a6d0-458b-9860-8e0a5a14f0bf",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_m2m_db_table",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_m2m_db_table(self, opts)"
}
```
