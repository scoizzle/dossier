# Fact 77600a63

Store id: 8cf6aaa1-885b-469b-b2a7-51d263cb7e66

## Text

```text
def refs_expression(lookup_parts, annotations)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.1734710+00:00`

## Data

```json
{
  "end_line": 488,
  "entity_kind": "function",
  "parent": "query_utils",
  "start_line": 478,
  "symbol": "refs_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":478,"selector":"L478-L488","symbol":"refs_expression"}`

## Items

```json
[
  {
    "text": "Check if the lookup_parts contains references to the given annotations set. Because the LOOKUP_SEP is contained in the default annotation names, check each prefix of the lookup_parts for a match.",
    "locator": {
      "line": 479
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::refs_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 488,
    "entity_kind": "function",
    "parent": "query_utils",
    "start_line": 478,
    "symbol": "refs_expression"
  },
  "id": "8cf6aaa1-885b-469b-b2a7-51d263cb7e66",
  "items": [
    {
      "locator": {
        "line": 479
      },
      "text": "Check if the lookup_parts contains references to the given annotations set. Because the LOOKUP_SEP is contained in the default annotation names, check each prefix of the lookup_parts for a match."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1734710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 478,
        "selector": "L478-L488",
        "symbol": "refs_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "fae1e27e-aa4b-4a75-a3fc-be46c035d116",
  "subject_name": "django/db/models/query_utils::refs_expression",
  "tags": [
    "entity:function"
  ],
  "text": "def refs_expression(lookup_parts, annotations)"
}
```
