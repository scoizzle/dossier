# Fact 44384905

Store id: b721e878-aea9-4866-bd4a-854c495efe18

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
- posted_at: `2026-11-09T23:31:58.8779080+00:00`

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
  "id": "b721e878-aea9-4866-bd4a-854c495efe18",
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
    "posted_at": "2026-11-09T23:31:58.8779080+00:00"
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
  "subject_id": "043a5161-2b6c-4344-a336-6a368a787775",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_m2m_reverse_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_m2m_reverse_attr(self, related, attr)"
}
```
