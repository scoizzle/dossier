# Fact 5b818ca9

Store id: 182ea324-e75c-4b37-aac2-25224f1e6d07

## Text

```text
def _get_m2m_attr(self, related, attr)
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
- posted_at: `2026-11-09T22:39:44.4893140+00:00`

## Data

```json
{
  "end_line": 2072,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2053,
  "symbol": "ManyToManyField._get_m2m_attr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2053,"selector":"L2053-L2072","symbol":"ManyToManyField._get_m2m_attr"}`

## Items

```json
[
  {
    "text": "Function that can be curried to provide the source accessor or DB column name for the m2m table.",
    "locator": {
      "line": 2054
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._get_m2m_attr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2072,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2053,
    "symbol": "ManyToManyField._get_m2m_attr"
  },
  "id": "182ea324-e75c-4b37-aac2-25224f1e6d07",
  "items": [
    {
      "locator": {
        "line": 2054
      },
      "text": "Function that can be curried to provide the source accessor or DB column name for the m2m table."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4893140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2053,
        "selector": "L2053-L2072",
        "symbol": "ManyToManyField._get_m2m_attr"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "7db192f2-da78-4175-9fbe-88102abb516d",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_m2m_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_m2m_attr(self, related, attr)"
}
```
