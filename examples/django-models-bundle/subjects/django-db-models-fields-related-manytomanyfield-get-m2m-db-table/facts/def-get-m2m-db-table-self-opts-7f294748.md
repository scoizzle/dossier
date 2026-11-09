# Fact 7f294748

Store id: 13e2d3e2-ae89-4601-b07d-8a196fa0e54c

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
- posted_at: `2026-11-09T22:39:44.4865630+00:00`

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
  "id": "13e2d3e2-ae89-4601-b07d-8a196fa0e54c",
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
    "posted_at": "2026-11-09T22:39:44.4865630+00:00"
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
  "subject_id": "d0b6ea89-40d6-4276-adcd-560e03fcf39d",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_m2m_db_table",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_m2m_db_table(self, opts)"
}
```
