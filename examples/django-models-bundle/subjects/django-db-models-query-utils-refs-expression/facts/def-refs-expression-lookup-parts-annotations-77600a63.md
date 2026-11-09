# Fact 77600a63

Store id: 7f534ca8-2833-4b51-9edf-fc65faa4f815

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
- posted_at: `2026-11-09T23:32:05.1902200+00:00`

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
  "id": "7f534ca8-2833-4b51-9edf-fc65faa4f815",
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
    "posted_at": "2026-11-09T23:32:05.1902200+00:00"
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
  "subject_id": "e1513c7a-ad8f-4ee2-ab0f-3c351367bc88",
  "subject_name": "django/db/models/query_utils::refs_expression",
  "tags": [
    "entity:function"
  ],
  "text": "def refs_expression(lookup_parts, annotations)"
}
```
