# Fact 44384905

Store id: bf3553f4-32c3-48af-9780-19c5f7c0af04

## Text

```text
def _get_m2m_reverse_attr(self, related, attr)
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
- posted_at: `2026-11-09T23:44:51.6629030+00:00`

## Data

```json
{
  "end_line": 2102,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2074,
  "symbol": "ManyToManyField._get_m2m_reverse_attr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2074,"selector":"L2074-L2102","symbol":"ManyToManyField._get_m2m_reverse_attr"}`

## Items

```json
[
  {
    "text": "Function that can be curried to provide the related accessor or DB column name for the m2m table.",
    "locator": {
      "line": 2075
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._get_m2m_reverse_attr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2102,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2074,
    "symbol": "ManyToManyField._get_m2m_reverse_attr"
  },
  "id": "bf3553f4-32c3-48af-9780-19c5f7c0af04",
  "items": [
    {
      "locator": {
        "line": 2075
      },
      "text": "Function that can be curried to provide the related accessor or DB column name for the m2m table."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6629030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2074,
        "selector": "L2074-L2102",
        "symbol": "ManyToManyField._get_m2m_reverse_attr"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e57bbe65-f358-4c05-b9aa-b1e6cbba6ea5",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_m2m_reverse_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_m2m_reverse_attr(self, related, attr)"
}
```
